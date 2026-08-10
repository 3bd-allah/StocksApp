import { createContext, useState } from "react";


const PersonsContext = createContext({
    persons, 
    getAllPersons:()=>{},
})

const PersonsProvider = ({children})=>{

    const [persons, setPersons] = useState([]);


    return (
        <PersonsContext>
            {children}
        </PersonsContext>
    )
}

export default PersonsContext; 