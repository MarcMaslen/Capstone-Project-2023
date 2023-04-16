import React from 'react'
import './buy_now.css'
import Button from '../../components/button/Button'
import { FaSteam } from 'react-icons/fa'

//This is the buy now section on the home page. It is a simple sections that gives a brief description of the game and the developer.

function Buynow() {

  return (
    <div className='buy_now-container' id="buynow">
        <div className='buy_now-content'>
            <h1>Medieval Magic</h1>
            <h2>Available Soon! <FaSteam></FaSteam></h2>
            <div className='game-content'>
            <img src={require("../../assets/poster2.png")} alt='enemies'></img>
            <p>Dive into Medieval warfare now and use Magic to defend your kingdom!  Click below!</p>
                <div className='game-info'>
                  <a href="https://swiftyair.itch.io/medieval-magic" target="_blank">
                    <button type="submit" className="btn btn-primary"> Buy Now </button>
                  </a>
                </div>
            </div>
        </div>
    </div>
  )
}

export default Buynow