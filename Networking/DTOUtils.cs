using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab1.Domain;

namespace Networking
{
    class DTOUtils
    {
        
            public static Angajat getFromDTO(AngajatDTO usdto)
            {
                int id = usdto.Id;
                string password = usdto.Parola;
                string user = usdto.User;
                return new Angajat(id, user, password);

            }
            public static AngajatDTO getDTO(Angajat user)
            {
                int id = user.Id;
                string password = user.Parola;
                string userName = user.User;
                return new AngajatDTO(id, userName, password);
            }



            public static AngajatDTO[] getDTO(Angajat[] users)
            {
                /*UserDTO[] frDTO =new UserDTO[users.Length];
                for(int i=0;i<users.Length;i++)
                {
                    frDTO[i]=getDTO(users[i]);
                }
                return frDTO;*/
                return null;
            }

            
        }

}
