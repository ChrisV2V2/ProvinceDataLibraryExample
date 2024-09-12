using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvinsePopulationLibrary
{

    
    public class ProvinceData
    {
        List<Province> province{ get; set;}

        public ProvinceData()
        {
            province = new List<Province>();
            province.Add(new Province { provinceName = "Gauteng", provincePopulation = 16100000, provinceCode = "GP" });
            province.Add(new Province { provinceName = "North-West", provincePopulation = 4180000, provinceCode = "NW" });
            province.Add(new Province { provinceName = "Western Cape", provincePopulation = 7260000, provinceCode = "WC" });
            province.Add(new Province { provinceName = "Northen Cape", provincePopulation = 1300000, provinceCode = "NC" });
            province.Add(new Province { provinceName = "KwaZulu-Natal", provincePopulation = 11540000, provinceCode = "KZN" });
            province.Add(new Province { provinceName = "Eastern Cape", provincePopulation = 6570000, provinceCode = "EC" });
            province.Add(new Province { provinceName = "Limpopo", provincePopulation = 6180000, provinceCode = "LP" });
            province.Add(new Province { provinceName = "Mpumalanga", provincePopulation = 4740000, provinceCode = "MP" });
            province.Add(new Province { provinceName = "Free State", provincePopulation = 2920000, provinceCode = "FS" });
        }

        public String getProvinceName(String code)
        {
            var province = this.province.FirstOrDefault(x => x.provinceCode == code);
            if (province != null)
            {
                return province.provinceName;
            }
            else
            {
                return $"No province is South Africa matches the code:  {code}";
            }
        }

        public int getPopulation(string provinceCode)
        {

            var province = this.province.FirstOrDefault(x => x.provinceCode == provinceCode);
            if (province != null)
            {
                return province.provincePopulation;
            }
            else
            {
                return 0;
            }
        }

        public Province getProvinceDetailsByName(string provinceName)
        {
            var province = this.province.FirstOrDefault(x => x.provinceName.Equals(provinceName, StringComparison.OrdinalIgnoreCase));
            return province;
        }
    }
}
