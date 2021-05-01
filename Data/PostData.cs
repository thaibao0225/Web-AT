using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_AT.Models;

namespace Web_AT.Data
{
    public class PostData
    {
        Posts Posts;
        List<Posts> postsList;

        public PostData()
        {
            SetPostData();
        }

        public void SetPostData()
        {
            postsList = new List<Posts>();
            //https://zingnews.vn/luong-nguoi-den-bai-bien-vung-tau-tang-dot-bien-post1210298.html
            postsList.Add(new Posts {
                Id = 1,
                Title = "Lượng người đến bãi biển Vũng Tàu tăng đột biến",
                ContentHeader = "Ngày thứ hai của kỳ nghỉ lễ 30/4-1/5, Bãi Sau (TP Vũng Tàu) thu hút hàng vạn du khách đến tắm biển. ",
                Content ="Khoảng 7h, rất đông du khách, người dân đã kéo đến bãi biển Bãi Sau để tắm biển. Đây là bãi biển lớn nhất của TP Vũng Tàu.",
                ImdUrl = "https://znews-photo.zadn.vn/w1200/Uploaded/kbfoplb/2021_05_01/DSC_1953_zing.jpg"
            });


            //https://zingnews.vn/cong-nhan-nhay-khoi-chung-cu-o-tphcm-dang-boc-chay-post1210331.html
            postsList.Add(new Posts
            {
                Id = 2,
                Title = "Công nhân nhảy khỏi chung cư ở TP.HCM đang bốc cháy",
                ContentHeader = "Bốn người bị thương khi chung cư ở quận 1 (TP.HCM) phát hỏa. Trong lúc cảnh sát dập lửa thì phát hiện thêm 2 người bị ngạt khói. ",
                Content = "Vụ cháy xảy ra khoảng 10h15 ngày 1/5 tại dãy chung cư 3 tầng trên đường Trần Hưng Đạo, phường Phạm Ngũ Lão, quận 1, TP.HCM. /n" +
                "Thời điểm trên, lửa bùng lên tại tầng trệt dãy chung cư số 48, 50, 52 Trần Hưng Đạo đang có một số công nhân đang sửa chữa. Phát hiện cháy, nhiều người hô hoán dập lửa nhưng bất thành. /n" +
                "Lửa bùng lên cháy dữ dội, lúc này có 4 công nhân đang thi công trên tầng 2 của chung cư la hét kêu cứu.",
                ImdUrl = "https://znews-photo.zadn.vn/w860/Uploaded/zxgorz/2021_05_01/chung_cu.jpg"
            });


            //https://zingnews.vn/doanh-thu-vingroup-vuot-1-ty-usd-lai-rong-tang-hon-70-post1210267.html
            postsList.Add(new Posts
            {
                Id = 3,
                Title = "Doanh thu Vingroup vượt 1 tỷ USD, lãi ròng tăng hơn 70%",
                ContentHeader = "Với doanh thu vượt 1 tỷ USD quý đầu năm nay và chi phí thuế thu nhập doanh nghiệp thấp hơn cùng kỳ, Tập đoàn Vingroup ghi nhận khoản lãi ròng tăng gần 72%.",
                Content = "Tập đoàn Vingroup (VIC) vừa công bố báo cáo tài chính hợp nhất quý I với khoản doanh thu và lợi nhuận ròng sau thuế tăng lần lượt 51% và 72% so với cùng kỳ năm trước. Kết quả này cũng kết thúc đà suy giảm doanh thu và lợi nhuận trong quý I của 2 năm liên tiếp trước đó tại Vingroup. /n" +
                "Cụ thể, 3 tháng đầu năm, doanh nghiệp của tỷ phú Phạm Nhật Vượng mang về 23.305 tỷ đồng doanh thu, tăng mạnh 51% so với số thu gần 15.500 tỷ cùng kỳ quý I/2020. /n" +
                "Nhờ cải thiện đáng kể biên lãi gộp trong kỳ này (từ 12,9% lên 14,1%) mà đà tăng của lợi nhuận gộp lớn hơn đà tăng doanh thu, đạt 3.285 tỷ đồng, cao hơn 65% so với cùng kỳ.",
                ImdUrl = "https://znews-photo.zadn.vn/w1200/Uploaded/aohunkx/2021_05_01/landmark.jpg"
            });

            
        }

        public List<Posts> GetPostData()
        {
            return postsList;
        }

    }
}
