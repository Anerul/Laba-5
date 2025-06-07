using System.Web.Mvc;

public class StudentUnionController : Controller
{
    private static StudentUnion[] _members = new StudentUnion[100];
    private static int _currentIndex = 0;

    public ActionResult Index()
    {
        return View(_members);
    }

    public ActionResult Details(int id)
    {
        return View(_members[id]);
    }

    public ActionResult Create()
    {
        return View();
    }

    public ActionResult AllMembers()
    {
        ViewData["UseInternalHelper"] = true;
        return View(_members);
    }

    [HttpPost]
    public ActionResult Create(StudentUnion member)
    {
        if (_currentIndex < _members.Length)
        {
            _members[_currentIndex] = member;
            _currentIndex++;
            return RedirectToAction("Index");
        }
        ModelState.AddModelError("", "Достигнут максимум членов профсоюза");
        return View(member);
    }


}