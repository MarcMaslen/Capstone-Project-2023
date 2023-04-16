import React from 'react'
import Footer from '../Footer/Footer'
import './AboutPage.css'

//This is the about page. It is a simple page that gives a description of the game and what its features are.

function AboutPage() {
  return (
    <div className='about-container2'>
        <div className='title2'>
            <h1>About</h1>
            <h2>Here you can learn all about the game and its features!</h2>
        </div>
        <div className='about-content2'>
            <div className='half-container'>
                <h1>What is Medieval Magic?</h1>
                <p>Medieval Magic is a game where you can create your adventure and take down the evil undead! 
                  I wanted to make a game which is inspired by the variety of tower defense games out There,
                  while delivering on a unique experience.<br/><br/> Medieval Magic bring a variety of maps, magic towers,
                  and enemies to fight against. As well as a progression system in the form of levels and upgrades.<br/><br/>
                  Medieval Magic is a game which is constantly being updated and improved, so keep an eye out for new features and content!
                </p>
            </div>
            <div className='half-container2'>
              <img src={require("../../assets/poster2.png")} alt='enemies'></img>
            </div>
        </div>
        <Footer />   
    </div>
  )
}

export default AboutPage