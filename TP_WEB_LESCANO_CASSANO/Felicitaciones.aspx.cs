﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_WEB_LESCANO_CASSANO
{
	public partial class Felicitaciones : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnInicio_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/Index.aspx");
		}
	}
}