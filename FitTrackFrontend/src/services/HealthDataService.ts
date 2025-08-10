import axios from 'axios';

export const sendHealthData = async (data) => {
  await axios.post('/api/healthdata', data);
};