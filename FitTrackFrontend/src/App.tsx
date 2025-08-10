import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import HomePage from './pages/HomePage';
import UserProfilePage from './pages/UserProfilePage';
import WorkoutPlansPage from './pages/WorkoutPlansPage';
import NutritionPlansPage from './pages/NutritionPlansPage';
import AIPlanGenerationPage from './pages/AIPlanGenerationPage';

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<HomePage />} />
        <Route path="/profile" element={<UserProfilePage />} />
        <Route path="/workouts" element={<WorkoutPlansPage />} />
        <Route path="/nutrition" element={<NutritionPlansPage />} />
        <Route path="/ai" element={<AIPlanGenerationPage />} />
      </Routes>
    </Router>
  );
}

export default App;