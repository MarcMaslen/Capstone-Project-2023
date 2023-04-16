import React from "react";
import "./footer.css";

//This is the footer section which goes on every page and contains links to each part of the website for quick naviagation.

function Footer() {
  return (
    <div className="footer-container">
      <div className="footer-sections">
        <div className="footer-left">
          <div className="title">
            <p>Navigation</p>
          </div>
          <ul className="footer-links">
            <li>
              <a href="/">Home</a>
            </li>
            <li>
              <a href="/About">About</a>
            </li>
            <li>
              <a href="/Purchase">Buy Now</a>
            </li>
            <li>
              <a href="/Contact">Contact</a>
            </li>
            <li>
              <a href="/login">Login</a>
            </li>
          </ul>
        </div>
        <div className="footer-middle">
          <div className="title">
            <p>Legal</p>
          </div>
          <ul className="footer-links">
            <li>
              <a href="/">Privacy Policy</a>
            </li>
            <li>
              <a href="/">Refund Policy</a>
            </li>
            <li>
              <a href="/">Purchase Policy</a>
            </li>
          </ul>
          <p>@2022 - Marc Maslen Corporation</p>
        </div>
        <div className="footer-right">
          <div className="title">
            <p>Social Media</p>
          </div>
          <ul className="footer-links">
            <li>
              <a href="https://swiftyair.itch.io/medieval-magic" target="_blank">Itch.IO</a>
            </li>
            <li>
              <a href="https://twitter.com/Swiftyair1" target="_blank">Twitter</a>
            </li>
            <li>
              <a href="/">Steam</a>
            </li>
            <li>
              <a href="/">Epic Games</a>
            </li>
            <li>
              <a href="/">Instagram</a>
            </li>
          
          </ul>
        </div>
      </div>
    </div>
  );
}

export default Footer;
