using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace BTLLTW_webBanQuanAo
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // FOR CATEGORY:
            // 1 --> 4: NAM 
            // 1: Do mac hang ngay (m_casual)
            // 2: Do cong so (m_works)
            // 3: Do the thao (m_sports)
            // 4: Do lot (m_underwear)
            // Tuong tu: 5 -- > 9: NU (f_casual , f_ ,...)
            // 10: Tre em (kids)

            List<Item> itemList = new List<Item>();
            itemList.Add(new Item(1, "Áo Khoác Gió Thông Minh Nữ Trượt Nước", "resource/aogio_1.jpg", 5, 599000, 539000));
            itemList.Add(new Item(2, "Áo Khoác Gió Nam Thông Minh Trượt Nước", "resource/aogio_2.jpg", 1, 599000, 539000));
            itemList.Add(new Item(3, "Áo Khoác Gió Thông Minh Trẻ Em Trượt Nước", "resource/aogiotreem_3.png", 9, 0, 499000));
            itemList.Add(new Item(4, "Áo Khoác Gió Thể Thao Nam Một Lớp Phối Khóa", "resource/aokhoacthethao_1.png", 3, 599000, 539000));
            
            itemList.Add(new Item(5, "Aó thu đông Nam giữ nhiệt cổ 3cm", "resource/male_casual/Áo Thun Đông Nam Giữ Nhiệt Cổ 3cm-ATM7011-TRA (2).jpg", 1, 299000, 239000));
            itemList.Add(new Item(6, "Aó thu đông Nam giữ nhiệt cổ tròn", "resource/male_casual/ao-thu-dong-nam-giu-nhiet-co-tron-yody-ATM7004-GHI (5).jpg", 1, 0, 179000));
            itemList.Add(new Item(7, "Áo thun nam clean Việt Nam", "resource/male_casual/ao-thun-nam-clean-yody-tsm7137-ghi-1.jpg", 1, 0, 299000));
            itemList.Add(new Item(8, "Áo Tshirt Yoguu Living Legend", "resource/male_casual/gut7020-xdd-3.jpg", 1, 349000, 174500));
            itemList.Add(new Item(9, "Quần Short Jeans nam ", "resource/male_casual/quan-short-jeans-nam-yody-SJM7038-XDM (1).jpg", 1, 0, 339000));
            itemList.Add(new Item(10, "Quần Short Nam Đen", "resource/male_casual/quan-short-jeans-nam-sjm6003-den-2-yody.jpg", 1, 0, 299000));
            itemList.Add(new Item(11, "Quần Short Nam Yoogu", "resource/male_casual/quan-short-nam-yoguu-gus7004-den-1.jpg", 1, 0, 299000));

            itemList.Add(new Item(12, "Aó sơ mi nam cộc tay", "resource/male_work/ao-so-mi-nam-coc-tay-yody-scm7037-ghi-14.jpg", 2, 0, 529000));
            itemList.Add(new Item(13, "Aó sơ mi nam dài tay 1", "resource/male_work/smm5207-den-6.jpg", 2, 600000, 569000));
            itemList.Add(new Item(14, "Aó sơ mi nam dài tay 2", "resource/male_work/ao-so-mi-nam-dai-tay-yody-smm6133-kxe-2.jpg", 2, 0, 529000));
            itemList.Add(new Item(15, "Sơ Mi Sợi Tre Dài Tay Quốc Dân", "resource/male_work/ao-so-mi-nam-SMM7007-TRA (1).jpg", 2, 0, 399000));
            itemList.Add(new Item(16, "Sơ Mi Dài Tay Nam Ly Chiết", "resource/male_work/ao-so-mi-nam-dai-tay-yody-smm6095-xlo-11.jpg", 2, 0, 529000));
            itemList.Add(new Item(17, "Quần Âu Nam Classic Phối Lé", "resource/male_work/qam6075-xde-smm6087-xnh-3.jpg", 2, 0, 499000));
            itemList.Add(new Item(18, "Quần Âu Nam Cạp Di Động", "resource/male_work/quan-au-nam-QAM7015-DN1 (1).jpg", 2, 0, 499000));

            //new
            itemList.Add(new Item(19, "Áo thun Thể Thao Nam", "resource/male_sports/ao-thun-the-thao-nam-stm7073-den-1.jpg", 3, 0, 349000));
            itemList.Add(new Item(20, "Áo Polo Thể Thao Nam Airy Cool Phối Bo", "resource/male_sports/Ao-polo-the-thao-nam.jpg", 3, 0, 379000));
            itemList.Add(new Item(21, "Quần Sooc Thể Thao Nam In Sau", "resource/male_sports/quan-short-nam-sqm6025-xcv-8.jpg", 3, 399000, 199500));
            itemList.Add(new Item(22, "Quần Gió Thể Thao Nam 4 Mùa", "resource/male_sports/quan-gio-nam-the-thao-yody-sgm6021-ghd-stm6087-tit-6-2.jpg", 3, 0, 469000));
            itemList.Add(new Item(23, "Áo thun Thể Thao Nam", "resource/male_sports/Bo-Do-the-thao-nam-in-super-sport.jpg", 3, 0, 949000));
            itemList.Add(new Item(24, "Áo Khoác Gió Thể Thao Nam Một Lớp Phối Khóa", "resource/male_sports/ao-khoac-gio-nam-the-thao-yody-SKM7005-DEN-5.jpg", 3, 599000, 500000));

            itemList.Add(new Item(25, "T-shirt Nữ Dáng Rộng In Cô Gái Chất Liệu Cotton Usa", "resource/female_casual/ao-thun-nu-tsn6088-tr1-7.jpg", 4, 0, 99000));
            itemList.Add(new Item(26, "Áo Thu Đông Nữ Mickey And Friend", "resource/female_casual/ao-thu-dong-nu-mickey-and-friend-yody-atn6136-ddo-6.jpg", 4, 0, 499000));
            itemList.Add(new Item(27, "Áo Thu Đông Nữ Dáng Ôm Khuyên Cổ", "resource/female_casual/ao-thun-thu-dong-dai-tay-yody-atn6024-xla-cvn6064-kem-3.jpg", 4,0, 249000));
            itemList.Add(new Item(28, "Quần Jeans Nữ Skinny Lưng Cao Hack Dáng", "resource/female_casual/quan-jean-nu-5068-xah-7.jpg", 4, 0, 149000));
            itemList.Add(new Item(29, "Quần Đùi Nữ Thể Thao Basic", "resource/female_casual/quan-the-thao-ssn7046-ghi-2.jpg", 4, 349000, 175500));
            itemList.Add(new Item(30, "Váy Thun Nữ Dáng Rộng Phố Tay Madrid", "resource/female_casual/vtn6014-dtv-6-75da344e-8e41-48db-9062-17bd7af4bbd1.jpg", 4, 0, 99000));

            itemList.Add(new Item(31, "Áo Sơ Mi Tay Dài Nữ Cổ Đức Tay Phối Voan", "resource/female_work/ao-so-mi-nu-SMN7124-BEE (1).jpg", 5, 0, 399000));
            itemList.Add(new Item(32, "Áo Sơ Mi Tay Ngắn Nữ Tay Phối Tơ Bồng", "resource/female_work/ao-so-mi-nu-tay-ngan.jpg", 5, 0, 499000));
            itemList.Add(new Item(33, "Áo Sơ Mi Tay Dài Nữ Cổ Bèo Dáng Suông", "resource/female_work/ao-so-mi-tay-dai-nu-co-beo-dang-suong-smn6078-cam-5.jpg", 5, 500000, 399000));
            itemList.Add(new Item(34, "Quần Âu Nữ Suông Siêu Co Giãn", "resource/female_work/quan-au-nu-qan7024-den-5.jpg", 5, 0, 399000));
            itemList.Add(new Item(35, "Quần Âu Nữ Dáng Baggy Cúc Trang Trí Mí Gân", "resource/female_work/qan6170-nad-12-5.jpg", 5, 399000, 199500));
            itemList.Add(new Item(36, "Chân Váy Nữ Dập Ly Xoè Cơ Bản", "resource/female_work/chan-vay-nu-yody-cvn7052-ghs-1.jpg", 5, 440000, 224500));
            itemList.Add(new Item(37, "Váy Nữ Tay Bồng", "resource/female_work/van6170-den-2.jpg", 5, 0, 149000));

            itemList.Add(new Item(38, "Bộ Đồ Thể Thao Nữ Nỉ Có Mũ In Logo", "resource/female_sports/do-bo-nu-sdn6036-csh-4.jpg", 6, 0, 849000));
            itemList.Add(new Item(39, "Áo Polo Thể Thao Nữ Airycool Phối Nẹp", "resource/female_sports/ao-polo-the-thao-nu-san5028-xlo-1.jpg", 6, 0, 329000));
            itemList.Add(new Item(40, "T-shirt Nữ Yody Sport", "resource/female_sports/t-shirt-nu-sport.jpg", 6, 0, 299000));
            itemList.Add(new Item(41, "Quần Thể Thao Nữ Túi Cạp", "resource/female_sports/quan-short-the-thao-nu-yody-ssn7018-ghi-13.jpg", 6, 349000, 174500));
            itemList.Add(new Item(42, "Quần Thể Thao Nữ Túi Cạp Sau", "resource/female_sports/quan-the-thao-nu-yody-sgn6002-gre-5.jpg", 6, 0, 549000));
            itemList.Add(new Item(43, "Áo Khoác Thể Thao Nữ Siêu Nhẹ", "resource/female_sports/ao-khoac-nu-SKN7004-HOG (1).jpg", 6, 0, 399000));

            itemList.Add(new Item(44, "Đồ Bộ Kid Phối Kẻ In Xe", "resource/kids/bo-do-tre-em-bdk6084-tla-2.jpg", 7, 299000, 149500));
            itemList.Add(new Item(45, "Bộ Đồ Trẻ Em In Faster", "resource/kids/bo-do-tre-em-bdk7126-tbl-1.jpg", 7, 0, 269000));
            itemList.Add(new Item(46, "Bộ Đồ Thu Đông Kid Tennis", "resource/kids/bo-do-tre-em-btk6084-den-1.jpg", 7, 0, 499000));
            itemList.Add(new Item(47, "Áo Dài Tay Kid Tomorrow", "resource/kids/ao-thun-tre-em-atk7024-vag-1.jpg", 7, 0, 149000));
            itemList.Add(new Item(48, "Quần Dài Kid Nhỏ Khóa Gối", "resource/kids/qnk6052-den-8.jpg", 7, 0, 269000));
            itemList.Add(new Item(49, "Đầm bé gái gấu nhún chấm bi", "resource/kids/vnk5292-tim01.jpg", 7, 0, 99000));
            itemList.Add(new Item(50, "T-shirt Kid You Are Loved", "resource/kids/ao-thun-tre-em-TSK7247-DEN (1).jpg", 7, 0, 149000));
            itemList.Add(new Item(51, "Quần Short Bé Trai Khoá Ngang Gố", "resource/kids/qsk7008-den-apk5019-xd1-3-2.jpg", 7, 220000, 114500));



            Application["itemList"] = itemList;

            List<User> users = new List<User>();
            users.Add(new User(1, "admin", "admin123", "admin"));
            Application["Users"] = users;
        }
    }
}