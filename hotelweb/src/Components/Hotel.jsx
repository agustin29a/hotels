import { Card, Space } from "antd";
import { Link } from "react-router";
import CardHotel from "./CardHotel";

const Hotel = ({ hotel }) => {
  return (
    <Space direction="vertical" size={16}>
      <Card
        title={hotel.name}
        extra={<Link to={`/hotels/${hotel.id}`}>Detail</Link>}
        style={{
          width: 300,
          margin: 20,
        }}
      >
        <CardHotel hotel={hotel} />
      </Card>
    </Space>
  );
};

export default Hotel;
