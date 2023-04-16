import React from 'react';
import { useForm } from '@formspree/react';


function Email() {
  const [state, handleSubmit] = useForm("xwkjvyqr");
  if (state.succeeded) {
      return <div>Thanks for joining!</div>;
  }
  return (
    <form onSubmit={handleSubmit}>
     <label htmlFor="email">Email</label>
        <input id="email" type="email" name="email" />
        <button type="submit" disabled={state.submitting}>Sign up</button>
    </form>
  );
}

export default Email;
