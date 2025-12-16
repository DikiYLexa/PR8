using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Models
{
    public class DataResponse
    {
        public List<Forecast> forecast {  get; set; }
    }
    public class Forecast
    {
        public DateTime date { get; set; }
        public List<Hour> hours { get; set; }
    }
    public class Hour
    {
        public string hour { get; set;}
        public string condition { get; set;}
        public int humidity {  get; set;}
        public int prec_type { get; set;}
        public int temp {  get; set;}
        public int uv_index { get; set;}
        public int visibility { get; set;}
        public int wind_angle { get; set;}
        public string wind_dir { get; set;}
        public double wind_gust { get; set;}
        public double wind_speed { get; set;}
        public int? cloud_cover_hight { get; set;}
        public int? cloud_cover_middle { get; set;}
        public int? cloud_cover_low { get; set;}
    }
}
