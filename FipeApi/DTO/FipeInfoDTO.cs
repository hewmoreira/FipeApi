namespace FipeApi.DTO
{
    public class FipeInfoDTO
    {
        public int VehiclePrice { get; set; }

        public FipeInfoDTO(int vehiclePrice)
        {
            VehiclePrice = vehiclePrice;
        }
    }
}
