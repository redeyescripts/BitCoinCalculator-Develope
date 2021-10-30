namespace BitCoinCalculator
{
    public class DogeCoinRates
    {
        public dpi dpi { get; set; }
    }
    public class dpi
    {
        public EURO EURO { get; set; }
        public US US { get; set; }

    }
    public class EURO
    {
        public string code { get; set; }
        public float rate_float { get; set; }
    }
    public class GetDoge
    {
        private GetDoge getDoge;
        public GetDoge GetGetDoge()
        {
            return getDoge;
        }
        public void SetGetDoge(GetDoge value)
        {
            getDoge = value;
        }


    }
    public class US
    {
        public string code { get; set; }
        public float rate_float { get; set; }

    }
}