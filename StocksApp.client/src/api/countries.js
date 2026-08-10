import { countryApi } from "./configuration/axios-custom-config";


export async function getAllCountries (){

    try{
        const { data: countries } = await countryApi.get('/country')
        return countries; 
    }catch(errEx){
        const error = new Error(errEx);
        console.log(errEx.message)
        throw error; 
    }
}

export async function  uploadCountriesExcelFileApi ({file, onProgress}){

    const formData = new FormData();
    formData.append('excelFile', file);
    try{
        const { data : numberOfCountries } = await countryApi.post('/country/upload-excel', formData, {
            headers: {
                "Content-Type":"multipart/form-data"
            },
            onUploadProgress: (progressEvent)=>{
                if(progressEvent.total){
                    const percentCompleted = Math.round((progressEvent.loaded * 100) / progressEvent.total);
                    onProgress(percentCompleted)
                }
            }
        })
        return numberOfCountries;
    }catch (err){
        const error ={
            title: err.response?.data?.title,
            message: err.response?.data?.detail,
            errors: null
        }
        throw error;
    }

}