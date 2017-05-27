using ComicBookGallery.Data;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            ActionResult _result;

            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.GetComicBook((int)id);

            _result = View(comicBook);

            return _result;
        }
    }
}