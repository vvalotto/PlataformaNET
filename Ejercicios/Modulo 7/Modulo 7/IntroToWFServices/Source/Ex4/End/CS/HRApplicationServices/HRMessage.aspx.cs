﻿// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using HRApplicationServices.Resources;

namespace HRApplicationServices
{
    public partial class HRMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string MsgID = Request.QueryString["MsgID"];

            if (!string.IsNullOrEmpty(MsgID))
            {
                switch (MsgID)
                {
                    case "AppIDStatusUpdated":
                        this.LabelError.Text = string.Format(WebResources.AppIDStatusUpdated, Request.QueryString["AppID"], Request.QueryString["Status"]);
                        break;
                    default:
                        this.LabelError.Text = WebResources.ResourceManager.GetString(MsgID);
                        break;
                }
            }
        }
    }
}