import { Routes, Route, Navigate } from "react-router";
import ListHotels from "../Components/ListHotels";
import HotelDetail from "../Components/HotelDetail";

const AppRoutes = () => {
  return (
    <Routes>
      <Route path="/hotels" element={<ListHotels />} />
      <Route path="/hotels/:id" element={<HotelDetail />} />
      <Route path="*" element={<Navigate to="/hotels" replace />} />
    </Routes>
  );
};

export default AppRoutes;
