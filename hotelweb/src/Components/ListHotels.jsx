import { useState, useEffect } from "react";
import { getHotels } from "../Services/hotelService";
import { Flex, Spin, Typography } from "antd";
import Hotel from "./Hotel";

const contentStyle = {
  padding: 50,
  background: "rgba(0, 0, 0, 0.05)",
  borderRadius: 4,
};

const { Title } = Typography;

const ListHotels = () => {
  const [hotels, setHotels] = useState(null);

  const fetchHotels = async () => {
    try {
      const respHotels = await getHotels();
      setHotels(respHotels);
    } catch (error) {
      console.error("Error fetching hotels:", error);
    }
  };

  useEffect(() => {
    fetchHotels();
  }, []);

  return (
    <div style={{ textAlign: "center" }}>
      <Title>LIST OF HOTELS</Title>
      {!hotels ? (
        <Flex gap="middle" vertical>
          <Spin tip="Loading" size="large">
            <div style={contentStyle} />
          </Spin>
        </Flex>
      ) : (
        hotels.map((hotel) => <Hotel key={hotel.id} hotel={hotel} />)
      )}
    </div>
  );
};

export default ListHotels;
