import React, { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import axios from 'axios';
import './DonationsForm.css';

const DonationsForm = () => {
  const [clients, setClients] = useState([]);
  const [selectedClient, setSelectedClient] = useState('');
  const [name, setName] = useState('');
  const [surname, setSurname] = useState('');
  const [phone, setPhone] = useState('');
  const [email, setEmail] = useState('');
  const [amount, setAmount] = useState('');
  const [message, setMessage] = useState('');
  const navigate = useNavigate();

  useEffect(() => {
    const fetchClients = async () => {
      try {
        const response = await axios.get('http://localhost:5128/api/donations/clients');
        setClients(response.data);
      } catch (error) {
        console.error('Error fetching clients', error);
      }
    };

    fetchClients();
  }, []);

  const handleSubmit = async (event) => {
    event.preventDefault();

    const data = {
      amount: parseFloat(amount),
      email: email,
      name: name,
      surname: surname,
      phone: phone,
      clientId: parseInt(selectedClient)
    };

    try {
      const response = await axios.post('http://localhost:5128/api/donations', data);

      if (response.data && response.data.success) {
        setMessage(response.data.message);
        // Actualizar el estado del cliente solo si UpdatedClient está definido
        if (response.data.updatedClient) {
          setClients(clients.map(client => 
            client.id === response.data.updatedClient.id ? response.data.updatedClient : client
          ));
          setSelectedClient(response.data.updatedClient.id); // Esto asegurará que la barra se actualice con el cliente actualizado
        }
        // Redirigir a la vista de donaciones
        navigate('/');
      } else {
        setMessage('Error procesando la donación (simulada)');
      }
    } catch (error) {
      console.error('Error al procesar la donación', error);
      setMessage('Error procesando la donación (simulada)');
    }
  };

  return (
    <div className="form-container">
      <h2>Formulario de Donación</h2>
      <form onSubmit={handleSubmit}>
        <div className="form-group">
          <label>Nombre:</label>
          <input
            type="text"
            value={name}
            onChange={(e) => setName(e.target.value)}
            required
          />
        </div>
        <div className="form-group">
          <label>Apellido:</label>
          <input
            type="text"
            value={surname}
            onChange={(e) => setSurname(e.target.value)}
            required
          />
        </div>
        <div className="form-group">
          <label>Número:</label>
          <input
            type="text"
            value={phone}
            onChange={(e) => setPhone(e.target.value)}
            required
          />
        </div>
        <div className="form-group">
          <label>Email:</label>
          <input
            type="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            required
          />
        </div>
        <div className="form-group">
          <label>Cantidad de Donación:</label>
          <input
            type="number"
            value={amount}
            onChange={(e) => setAmount(e.target.value)}
            required
          />
        </div>
        <div className="form-group">
          <label>Cliente Protésico:</label>
          <select value={selectedClient} onChange={(e) => setSelectedClient(e.target.value)} required>
            <option value="">Selecciona un cliente</option>
            {clients.map((client) => (
              <option key={client.id} value={client.id}>
                {client.name} {client.surname}
              </option>
            ))}
          </select>
        </div>
        <div className="form-group">
          <button type="submit" className="btn btn-primary">Donar</button>
        </div>
      </form>
      {selectedClient && clients.length > 0 && (
        <div className="progress-bar-container">
          <h3>Progreso de Donación</h3>
          {clients.filter(client => client.id == selectedClient).map(client => {
            const progress = (client.donationStatus / client.donationGoal) * 100;
            return (
              <div key={client.id}>
                <label>{client.name} {client.surname}</label>
                <div className="progress-bar">
                  <div className="progress" style={{ width: `${progress}%` }}></div>
                  <div className="progress-info">
                    <span>{client.donationStatus.toFixed(2)}</span>
                    <span>{client.donationGoal.toFixed(2)}</span>
                  </div>
                </div>
              </div>
            );
          })}
        </div>
      )}
      {message && <div className="message">{message}</div>}
    </div>
  );
};

export default DonationsForm;
