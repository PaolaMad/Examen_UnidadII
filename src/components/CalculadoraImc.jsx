import { useState, useEffect } from 'react';

const CalculadoraImc = (datos, setDatos) => {

    const [nombre, setNombre] = useState('');
    const [genero, setGenero] = useState('');
    const [peso, setPeso] = useState('');
    const [altura, setAltura] = useState('');

    const handleSubmit = (e) => {
        e.preventDefault();

        const objetoDatos = {
            nombre,
            genero,
            peso,
            altura
        }

        setDatos([... datos, objetoDatos])
        console.log('ambeces no es como queremos');

        setNombre('');
        setGenero('');
        setPeso('');
        setAltura('');

    }

    return (
        <div className='flex justify-center items-center bg-gray-400 h-auto'>
            <div class="md:w-1/2 lg:w-2/5 mt-5 p-3 rounded-md">
                <h2 className='text-center text-2xl text-white font-bold'>Calculadora de IMC</h2>
                <form id="imcForm" onSubmit={handleSubmit} className='mt-4'>
                    <div className='mb-5'>
                        <label for="nombre">Nombre:</label>
                        <input
                            value={nombre}
                            onChange={(e) => (e.target.value)}
                            type="text"
                            id="nombre"
                            name="nombre"
                            required />
                    </div>
                    <div className='mb-3'>
                        <label for="genero">Género:</label>
                        <select            
                            id="genero"
                            value={genero}
                            onChange={(e) => (e.target.value)}
                            name="genero"
                            required>
                            <option value="masculino">Masculino</option>
                            <option value="femenino">Femenino</option>
                        </select>
                    </div>
                    <div className='mb-3'>
                        <label for="peso">Peso (kg):</label>
                        <input
                            type="number"
                            value={peso}
                            onChange={handleSubmit}
                            id="peso"
                            name="peso"
                            required />
                    </div>
                    <div className='mb-3'>
                        <label for="altura">Altura (cm):</label>
                        <input
                        value={altura}
                            onChange={handleSubmit}
                            type="number"
                            id="altura"
                            name="altura"
                            required />
                    </div>
                    <button className='bg-blue-700 text-white' type="submit">Calcular IMC</button>
                </form>
                <div id="resultado"></div>
            </div>
        </div>

    )
}

export default CalculadoraImc