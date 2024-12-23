import apiClient from "./apiService";

export const getHotels = async () => {
  try {
    const response = await apiClient.get("/api/hotels");
    return response.data;
  } catch (error) {
    console.error("Error get hotels", error);
    throw error;
  }
};

export const getHotelById = async (id) => {
  try {
    const response = await apiClient.get(`/api/hotels/${id}`);
    return response.data;
  } catch (error) {
    console.error("Error get hotel", error);
    throw error;
  }
};
