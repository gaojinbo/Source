using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Cor.Pro.Model;
using Cor.Pro.IDal;
using Cor.Pro.Dal;
using Cor.Pro.IBll;
using Cor.Pro.Bll;

namespace WebTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //IEntityRepository _EntiryRepository = new EntityRepository();
            //MVCEntity entity = new MVCEntity()
            //{
            //    ID = Guid.NewGuid(),
            //    EntityName = "Jennifer",
            //    EntityAge = 24,
            //    EntityNotes = "I'm From UnitTest;"
            //};
            //_EntiryRepository.Add(entity);
        }
    }
}