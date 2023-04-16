import React from "react";
import "./contact.css";

//This is the contact page. It is a simple page that gives a form for the user to contact the developer.
//I didnt get the contact form working in the end as I ran out of time to complete that however the front end of the contact page was fully done.

function Contact() {
  return (
    <div className="contact-container" id="contact">
      <div className="contact-content">
        <div className="contact-left">
          <div className="contact-title">
            <h1>Contact Us!</h1>
          </div>
          {/* <form
              id="contact-form"
              onSubmit={this.handleSubmit.bind(this)}
              method="POST"
            > */}
          <div className="contact-form">
            <label htmlFor="name">Full Name:</label>
            <input type="text" className="form-control" />
          </div>
          <div className="contact-form">
            <label htmlFor="exampleInputEmail1">Email address:</label>
            <input
              type="email"
              className="form-control"
              aria-describedby="emailHelp"
            />
          </div>
          <div className="contact-form">
            <label htmlFor="message">Message:</label>
            <textarea
              className="form-control"
              maxlength="40"
              rows="5"
            ></textarea>
          </div>
          <button type="submit" className="btn btn-primary">
            Submit
          </button>
          {/* </form> */}
        </div>
        <div className="contact-right">
          <img
            src={require("../../assets/zombie_noback.png")}
            alt="enemies"
          ></img>
        </div>
      </div>
    </div>
  );
}

export default Contact;
