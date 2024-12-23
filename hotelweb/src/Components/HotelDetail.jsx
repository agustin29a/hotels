import { useParams } from "react-router";
import { useState, useEffect } from "react";
import { Card, Empty } from "antd";
import { getHotelById } from "../Services/hotelService";
import CardHotel from "./CardHotel";

const HotelDetail = () => {
  const { id } = useParams();
  const [hotel, setHotel] = useState(null);
  const [error, setError] = useState(false);

  const fetchHotels = async () => {
    try {
      const respHotel = await getHotelById(id);
      setHotel(respHotel);
    } catch (error) {
      setError(true);
      console.error("Error fetching hotel:", error);
    }
  };

  useEffect(() => {
    fetchHotels();
  }, []);

  return (
    <div className="centerCard">
      {!hotel && !error && <Empty description="Loading" />}
      {error && <Empty description="Hotel Not Found" />}
      {hotel && (
        <Card
          title={hotel.name}
          style={{
            width: 300,
            textAlign: "center",
          }}
        >
          <CardHotel hotel={hotel} />
        </Card>
      )}
    </div>
  );
};

export default HotelDetail;
