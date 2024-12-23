import { Image } from "antd";

const CardHotel = ({ hotel }) => {
  return (
    <>
      <p>{hotel.location}</p>
      <p>{hotel.rating}</p>
      <p>{hotel.boardBasis}</p>

      {hotel.datesOfTravel.map((date, index) => (
        <p key={index}>{date}</p>
      ))}

      {hotel.rooms.map((room, index) => (
        <div key={index}>
          <p>{room.roomType}</p>
          <p>{room.amount}</p>
        </div>
      ))}
      <Image width={200} src={hotel.imageUrl} />
    </>
  );
};

export default CardHotel;
