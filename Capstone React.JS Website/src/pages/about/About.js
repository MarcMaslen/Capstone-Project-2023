import React from "react";
import "./about.css";
import { GiFireAxe} from "react-icons/gi";
import Button from "../../components/button/Button";

//This is the about section on the home page. It is a simple sections that gives a brief description of the game and the developer.

function About() {
  return (
    <>
      <div className="about-container" id="about">
        <div className="about">
          <div className="title">
            <h1>About</h1>
          </div>
          <div className="about_main-container">
            <div className="about-content">
              <h2>Medieval Magic</h2>
              <div className="main-info">
                <div className="description">
                  <p>
                    Get ready to defend yourself from waves of the undead using
                    MAGIC. Fight mummy's, skeletons, Slimes and zombies! Find
                    out if you have what it takes to get through all the EPIC
                    levels and defeat the final boss.
                    <br /> <br />
                    There is a variety defenses, upgrades, and spells to help
                    you! Make your way through all the levels to unlock endless
                    mode! Check out our about page for more info!
                  </p>
                </div>
                {/* This is a placeholder image, I have yet to decide what will go here. Might be a video*/}
                <div className="picture">
                  <GiFireAxe className="logo-icon" />
                </div>
              </div>
            </div>
            <div className="about-content1"></div>
            <div className="about-content">
              <h2>Meet The Developer</h2>
              <p>My name is Marc Maslen. Medieval Magic was a game I made during my capstone project, along side this website to promote and show off the game.
                while in my third year of University.
                This project has been great for me to learn new skills and to improve my skills in areas I already knew. I have learned a lot about
                 React development, game development and marketing and I am very proud of what I have achieved.
                <br/><br/>
                I hope you have as much fun playing this game as I did making it! I would love to hear your feedback and any suggestions you may have.
              </p>
              <div className="picture-me">
              <img src={require("../../assets/Marc.jpeg")} className="img" alt="Marc Maslen" />
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
}

export default About;
