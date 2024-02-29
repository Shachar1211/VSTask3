namespace Task3.BL
{
    public class Vacation
    {
        int id;
        string userid;
        int flatid;
        DateTime startdate;
        DateTime enddate;

        public static List<Vacation> VacationsList = new List<Vacation>();

        public Vacation(int id, string userid, int flatid, DateTime startdate, DateTime enddate)
        {
            Id = id;
            Userid = userid;
            Flatid = flatid;
            Startdate = startdate;
            Enddate = enddate;
        }

        public Vacation()
        {

        }
        public int Id { get => id; set => id = value; }
        public string Userid { get => userid; set => userid = value; }
        public int Flatid { get => flatid; set => flatid = value; }
        public DateTime Startdate { get => startdate; set => startdate = value; }
        public DateTime Enddate { get => enddate; set => enddate = value; }

        public bool Insert()
        {
            if (!VacationsList.Exists(vacation => vacation.Id == this.Id))
            {
                if (CheackIfFlatAvilable())
                {
                    DBservices dbs = new DBservices();
                    dbs.InsertVacations(this);
                    return true;
                }
            }            
            return false;
        }

        public List<Vacation> Read()
        {
            DBservices dbs = new DBservices();
            return dbs.ReadVacations();
        }

        public bool CheackIfFlatAvilable()
        {
            foreach (Vacation vacation in VacationsList)
            {
                if (vacation.flatid == this.flatid)
                {
                    if (vacation.startdate <= this.enddate && vacation.enddate >= this.startdate)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public List<Vacation> ReadByDates(DateTime startdate, DateTime enddate)
        {
            List<Vacation> selectedList = new List<Vacation>();
            foreach (Vacation vacation in VacationsList)
            {
                if (vacation.startdate <= enddate && vacation.enddate >= startdate)
                {
                    selectedList.Add(vacation);
                }
            }
            return selectedList;
        }
    }
}
