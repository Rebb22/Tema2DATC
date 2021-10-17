using System;
using System.Collections.Generic; //biblio pt liste
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication2
{
    public static class StudentsRepository
    {
        public static List<Studentt> Students = new List<Studentt>()
        {
            new Studentt(){Id=1, Nume="Potocianu",Prenume="Rebecca", An_studiu=4, Facultate="AC" },
            new Studentt(){Id=2, Nume="Solomon",Prenume="David", An_studiu=3, Facultate = "AC" },
            new Studentt(){Id=3,Nume="Anghelescu",Prenume="Patrick",An_studiu=4,Facultate="ETC"}

        };
    }
}
