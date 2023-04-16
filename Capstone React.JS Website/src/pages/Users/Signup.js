import React from 'react'
import { getAuth, createUserWithEmailAndPassword } from "firebase/auth";
import { useState } from "react";
import app from '../../firebase';
import Footer from '../Footer/Footer';
import './signup.css'

function Signup() {

    const auth = getAuth(app);

    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");

    const signUp = () => {
        createUserWithEmailAndPassword(auth, email, password)
        .then((userCredential) => {
            // Signed in 
            const user = userCredential.user;
            console.log(user);
            alert("User Created");
        })
        .catch((error) => {
            const errorCode = error.code;
            const errorMessage = error.message;
            alert(errorMessage);
        });
    }

  return (
    <div className='auth-container'>
        <div className='auth-wrapper'>
            <div className="auth-section">
                <h1>Sign Up!</h1>
                <input type={"email"} placeholder="Enter your email" onChange={(e) => setEmail(e.target.value)} />
                <input type={"password"} placeholder="Enter your password" onChange={(e) => setPassword(e.target.value)} />

                <button onClick={signUp}>Sign Up</button>
                <h2>Already have an account? Login below!</h2>
                <a href='/login'><button>Login</button></a>
            </div>
        </div>  
        <Footer />  
    </div>
  )
}

export default Signup