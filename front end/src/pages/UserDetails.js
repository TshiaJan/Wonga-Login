import React, { useState, useEffect } from 'react';
import axios from 'axios';

function UserDetails() {
  const [user, setUser] = useState(null);

  useEffect(() => {
    const fetchDetails = async () => {
      try {
        const token = localStorage.getItem('token');
        const res = await axios.get('http://localhost:5000/api/auth/details', {
          headers: { Authorization: `Bearer ${token}` }
        });
        setUser(res.data);
      } catch (err) {
        alert('Error fetching details');
      }
    };
    fetchDetails();
  }, []);

  if (!user) return <div>Loading...</div>;

  return (
    <div>
      <h1>User Details</h1>
      <p>First Name: {user.firstName}</p>
      <p>Last Name: {user.lastName}</p>
      <p>Email: {user.email}</p>
    </div>
  );
}

export default UserDetails;
