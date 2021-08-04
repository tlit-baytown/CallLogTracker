using CallLogTracker.backend.database.wrappers;
using CallLogTracker.utility;

namespace CallLogTracker
{
    public class Global
    {
        private static Global instance = null;
        private static object padlock = new object();

        public static Global Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new Global();
                    return instance;
                }
            }
        }

        private Global()
        {

        }

        public bool DatabaseConnected { get; set; } = false;
        public int NumberOfDBConnectionFormsOpen { get; set; } = 0;
        public int NumberOfLoginFormsOpen { get; set; } = 0;

        public SortableBindingList<User> Users { get; set; } = new SortableBindingList<User>();
        public SortableBindingList<Company> Companies { get; set; } = new SortableBindingList<Company>();
        public SortableBindingList<Call> CallsToday { get; set; } = new SortableBindingList<Call>();

        public User CurrentUser { get; set; } = null;
        public Company CurrentCompany { get; set; } = null;

        public string SelectedPageUniqueName = "";

        public MainForm MainForm { get; set; }
    }
}
