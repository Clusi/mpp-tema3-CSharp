using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Networking
{
    [Serializable]
    class LogInRequest: IRequest
    {
        private AngajatDTO user;

        public LogInRequest(AngajatDTO user)
        {
            this.user = user;
        }

        public virtual AngajatDTO User
        {
            get
            {
                return user;
            }
        }
    }
}
