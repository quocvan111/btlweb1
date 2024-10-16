using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLLTW_webBanQuanAo
{
    public partial class male : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = renderItem();
            List<Item> items = (List<Item>)Application["itemList"];
            hienoday.InnerHtml = s;
            showTitle.InnerHtml = renderTitle();

        }

        private string renderTitle()
        {
            string category = Request.QueryString["category"];
            if (category == "male")
                return "NAM";
            else if (category == "female")
                return "NỮ";
            else return "";
        }

        private string renderItem()
        {
            string html = "";
            List<Item> list = (List<Item>)Application["itemList"];
            string category = Request.QueryString["category"];
            string loctien = "";
            loctien = Request.Form["filtertien"];

            //if (loctien == "giatren500")
            //{
            //    foreach (Item item in list)
            //    {
            //        if (item.Final_price > 500000)
            //        {
            //            html += generateString(item);
            //        }
            //    }
            //    return html;
            //}

            //if (loctien == "gia200-500")
            //{
            //    foreach (Item item in list)
            //    {
            //        if (item.Final_price > 200000 && item.Final_price < 500000)
            //        {
            //            html += generateString(item);
            //        }
            //    }
            //    return html;
            //}

            //if (loctien == "giaduoi200")
            //{
            //    foreach (Item item in list)
            //    {
            //        if (item.Final_price < 200000)
            //        {
            //            html += generateString(item);
            //        }
            //    }
            //    return html;
            //}

            if (category == "male")
            {
                if (loctien == "giatren500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category <= 3 && item.Final_price > 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "gia200-500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category <= 3 && item.Final_price > 200000 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "giaduoi200")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category <= 3 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                foreach (Item item in list)
                {
                    if (item.Category <= 3 && item.Final_price > 500000)
                    {
                        html += generateString(item);
                    }
                }
            }

            if (category == "m_casual")
            {
                if (loctien == "giatren500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 1 && item.Final_price > 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "gia200-500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 1 && item.Final_price > 200000 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "giaduoi200")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 1 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                foreach (Item item in list)
                {
                    if (item.Category == 1)
                    {
                        html += generateString(item);
                    }
                }
            }

            if (category == "m_work")
            {
                if (loctien == "giatren500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 2 && item.Final_price > 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "gia200-500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 2 && item.Final_price > 200000 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "giaduoi200")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 2 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                foreach (Item item in list)
                {
                    if (item.Category == 2)
                    {
                        html += generateString(item);
                    }
                }
            }

            if (category == "m_sports")
            {
                if (loctien == "giatren500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 3 && item.Final_price > 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "gia200-500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 3 && item.Final_price > 200000 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "giaduoi200")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 3 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                foreach (Item item in list)
                {
                    if (item.Category == 3)
                    {
                        html += generateString(item);
                    }
                }
            }

            if (category == "female")
            {
                if (loctien == "giatren500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category >= 4 && item.Final_price > 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "gia200-500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category >= 4 && item.Final_price > 200000 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "giaduoi200")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category >= 4 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                foreach (Item item in list)
                {
                    if (item.Category >= 4 && item.Category <= 6)
                    {
                        html += generateString(item);
                    }
                }
            }

            if (category == "f_casual")
            {
                if (loctien == "giatren500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 1 && item.Final_price > 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "gia200-500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 1 && item.Final_price > 200000 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "giaduoi200")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 1 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                foreach (Item item in list)
                {
                    if (item.Category == 4)
                    {
                        html += generateString(item);
                    }
                }
            }

            if (category == "f_work")
            {
                if (loctien == "giatren500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 5 && item.Final_price > 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "gia200-500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 5 && item.Final_price > 200000 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "giaduoi200")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 5 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                foreach (Item item in list)
                {
                    if (item.Category == 5)
                    {
                        html += generateString(item);
                    }
                }
            }

            if (category == "f_sports")
            {
                if (loctien == "giatren500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 6 && item.Final_price > 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "gia200-500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 6 && item.Final_price > 200000 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "giaduoi200")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 6 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                foreach (Item item in list)
                {
                    if (item.Category == 6)
                    {
                        html += generateString(item);
                    }
                }
            }

            if (category == "kid")
            {
                if (loctien == "giatren500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 7 && item.Final_price > 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "gia200-500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 7 && item.Final_price > 200000 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "giaduoi200")
                {
                    foreach (Item item in list)
                    {
                        if (item.Category == 7 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                foreach (Item item in list)
                {
                    if (item.Category == 7)
                    {
                        html += generateString(item);
                    }
                }
            }

            if (category == "sale")
            {
                if (loctien == "giatren500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Final_price > 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "gia200-500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Final_price > 200000 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "giaduoi200")
                {
                    foreach (Item item in list)
                    {
                        if (item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                foreach (Item item in list)
                {
                    if (item.Price != 0)
                    {
                        html += generateString(item);
                    }
                }
            }

            if (category == "new")
            {
                if (loctien == "giatren500")
                {
                    foreach (Item item in list)
                    {
                        if ( item.Final_price > 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "gia200-500")
                {
                    foreach (Item item in list)
                    {
                        if (item.Final_price > 200000 && item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }
                if (loctien == "giaduoi200")
                {
                    foreach (Item item in list)
                    {
                        if ( item.Final_price < 500000)
                        {
                            html += generateString(item);
                        }
                    }
                    return html;
                }

                foreach (Item item in list)
                {
                    html += generateString(item);
                }
            }

            return html;
        }

        private string generateString(Item item)
        {
            string html = "";
            html += "<div class='item'>" +
                        "<a href='ctsp.aspx?id=" + item.Id + "'>" +
                            "<img src='" + item.Image + "' alt=''>" +
                        "</a>" +
                        "<div class='item-info'>" +
                            "<p>" + item.Name + "<br/></p>" +
                            "<div class='price'>";

            if (item.Price == 0)
            {
                html += "<p class='price-after'>" + item.Final_price + " đ</p>";
            }
            else
            {
                html += "<p class='price-after'>" + item.Final_price + " đ</p>" +
                         "<sub class='price-before'>" + item.Price + " đ</sub>";
            }

            html += "</div>" +
                    "</div>" +
                    "</div>";
            return html;
        }
    }
}