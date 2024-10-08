using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebGrease;

namespace BTLLTW_webBanQuanAo
{
    public partial class ctsp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = renderItem();
            List<Item> items = (List<Item>)Application["itemList"];
            hienoday.InnerHtml = s;
        }

        private string renderItem()
        {
            string html = "";
            List<Item> list = (List<Item>)Application["itemList"];
            string id = Request.QueryString["id"];
            foreach (Item item in list)
            {
                if(item.Id == Int32.Parse(id))
                {
                    html += generateString(item);
                }
            }
            return html;
        }

        private string renderCategory(Item item)
        {
            if (item.Category == 1 || item.Category == 4)
                return "Đồ mặc hằng ngày";
            if (item.Category == 2 || item.Category == 5)
                return "Đồ công sở";
            if (item.Category == 3 || item.Category == 6)
                return "Đồ thể thao";
            else return "Đồ trẻ em";
        }

        private string generateString(Item item)
        {
            string html = "";
            html += "<div class='image col-6'>" +
                        "<img src='" + item.Image + "' alt=''>" +
                    "</div>" +
                    "<div class='info col-6'>" +
                        "<div class='title'><h3>" + item.Name + "</h3></div>" +
                        "<div class='category'>" + renderCategory(item) + "</div>" +
                        "<div class='price'><h2>" + item.Final_price + " đ</h2></div>" +
                        "<br/><p>Số lượng</p>" +
                        "<div class='row'>" +
                            "<div class='quantity'>" +
                                "<button class='button button-remove'>-</button>" +
                                "<div class='number' id='number-quantity'>" + 1 + "</div>" +
                                "<button class='button button-add'>+</button>" +
                            "</div>" +
                            "<button class='button button-tocart'>" +
                                "<p>Thêm vào giỏ</p>" +
                            "</button>" +
                        "</div>" +
                        "<a href='#'><button class='button-buy'>Mua ngay</button></a>" +
                        "<div class='payment-method'>" +
                            "<div class='images'>" +
                                "<img src='resource/payment_method/zalopay.jpg' alt='' width='87px'>" +
                                "<img src='resource/payment_method/visa-card.jpg' alt='' width='45px'>" +
                                "<img src='resource/payment_method/master-card.jpg' alt='' width='58px'>" +
                                "<img src='resource/payment_method/vnpay-qr.jpg' alt='' width='87px'>" +
                                "<img src='resource/payment_method/momo.jpg' alt='' width='36px'>" +
                            "</div>" +
                            "<p>Đảm bảo thanh toán an toàn và bảo mật</p>" +
                        "</div>" +
                        "<div class='info-policies'>" +
                            "<div class='inner-wrap'>" +
                                "<p><b>Miễn phí đổi trả: </b>Đơn hàng từ 498k</p>" +
                                "<p><b>Giao hàng: </b>3 - 5 ngày trên cả nước</p>" +
                                "<p><b>Miễn phí đổi trả: </b>Tại 267+ cửa hàng trong 15 ngày</p>" +
                                "<p>Thông tin bảo mật và mã hoá</p>" +
                            "</div>" +
                        "</div>" +
                        "<div class='info-describe'>" +
                            "<p><b>Mô tả sản phẩm</b></p>" +
                            "<ul>" +
                                "<li>" + item.Describe + "</li>" +
                            "</ul>" +
                        "</div>" +
                    "</div>";

            return html;
        }

    }
}