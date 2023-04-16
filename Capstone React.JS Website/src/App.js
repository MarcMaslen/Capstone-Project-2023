//import react from 'react';
import React from "react";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import Navbar from "./pages/navbar/Navbar";
import Signup from "./pages/Users/Signup";
import Home from "./pages/Home/Home";
import About from "./pages/aboutpage/AboutPage";
import Purchase from "./pages/purchase/Purchase";
import Contact from "./pages/contactPage/Contactpage";
import Login from "./pages/Users/Login";
import "./app.css";

//Main app component for the website. Combines all my main pages together.
//The Navbar is out of the sections div as it is always visible.
//The Routes are in the sections div as they are only visible when the user is on that page.
function App() {
  return (
    <Router>
      <div className="app">
        <Navbar /> 
        <div className="sections">
          <Routes>
          <Route exact path="/" element={<Home/>} /> 
          <Route exact path="/About" element={<About/>} />
          <Route exact path="/Purchase" element={<Purchase/>} />
          <Route exact path="/Contact" element={<Contact/>} />
          <Route exact path="/login" element={<Login/>} />
          <Route exact path="/signup" element={<Signup/>} />
          </Routes>
        </div>
      </div>
     </Router>
  );
}

export default App;
