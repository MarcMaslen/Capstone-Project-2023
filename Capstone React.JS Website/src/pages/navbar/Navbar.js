import React, {useState} from 'react'
import './navbar.css'
import { GiEmberShot } from 'react-icons/gi'
import {FaBars, FaTimes} from 'react-icons/fa'

const Navbar = () => {
    const [click, setClick] = useState(false)
    const handleClick = () => setClick(!click)

  return (
    <div className='navbar'>
        <div className='container'>
            <div className='logo'>
                <GiEmberShot className='logo-icon' />
                <a href="/">
                    <h1>Medieval Magic</h1>
                </a>
            </div> 
            <ul className={click ? "navbar-menu active" : "navbar-menu" }> 
                <li><a href='/'>Home</a></li>
                <li><a href='/About'>About</a></li>
                <li><a href='/Purchase'>Buy Now</a></li>
                <li><a href='/Contact'>Contact</a></li>
                <li><a href='/login'>Login</a></li>
            </ul>
            <div className='nav-menu-mobile' onClick={handleClick}>
                {click ? <FaTimes className='logo-icon' /> : <FaBars className='logo-icon' />}
                {/* <FaBars className='logo-icon' /> */}
            </div>
        </div>
    </div>
  )
}

export default Navbar