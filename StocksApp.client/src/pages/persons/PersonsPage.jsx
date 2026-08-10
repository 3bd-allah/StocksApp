import { Link, Outlet } from "react-router";
import { downloadPersonsPDF, downloadPersonsReportAsCSV, downloadPersonsReportAsExcel } from "../../api/persons";
import { useMutation } from "@tanstack/react-query";
import toast from "react-hot-toast";
const PersonsPage = () => {
  // console.log(personsPromise);

  const { mutate: downloadAsPDF, isPending: isDownloadingPdf } = useMutation({
    mutationFn: downloadPersonsPDF,
    onSuccess: () => {
      toast.success("PDF Downloaded Successfully");
    },
    onError:()=>{
      toast.error('An error occurred please try again later!')
    }
  });

  const {mutate: downloadCsv, isPending: isDownloadingCsv}= useMutation({
    mutationFn: downloadPersonsReportAsCSV,
    onSuccess:()=>{
      toast.success("CSV downloaded successfully")
    },
    onError:()=>{
      toast.error('An error occurred please try again later!')
    }
  })

    const {mutate: downloadExcel, isPending: isDownloadingExcel}= useMutation({
    mutationFn: downloadPersonsReportAsExcel,
    onSuccess:()=>{
      toast.success("Excel downloaded successfully")
    },
    onError:()=>{
      toast.error('An error occurred please try again later!')
    }
  })
  function handleDownloadPersonsAsPDF() {
    downloadAsPDF();
  }
  
  function handleDownloadPersonsAsCsv() {
    downloadCsv();
  }

  function handleDownloadPersonsAsExcel() {
    downloadExcel();
  }

  return (
    <div className="font-sans p-6 max-w-7xl mx-auto">
      {/* Page Title */}
      <h1 className="text-4xl font-bold text-gray-900 mb-6">Persons</h1>

      <div className="flex gap-10">
        <Link to="/persons/create-new" className="underline text-blue-400">
          Create New Person
        </Link>
        <button
          onClick={handleDownloadPersonsAsPDF}
          disabled={isDownloadingPdf}
          className="underline text-blue-400 hover:cursor-pointer"
        >
          {isDownloadingPdf ? "Downloading..." : "Download as PDF"}
        </button>
        <button
          onClick={handleDownloadPersonsAsCsv}
          disabled={isDownloadingCsv}
          className="underline text-blue-400 hover:cursor-pointer"
        >
          {isDownloadingCsv? 'Downloading...': 'Download as CSV'}
        </button>
        <button 
        onClick={handleDownloadPersonsAsExcel}
        disabled={isDownloadingExcel}
        className="underline text-blue-400 hover:cursor-pointer">
          {isDownloadingExcel? 'Downloading...': 'Download as Excel'}
        </button>
      </div>

      <Outlet />
    </div>
  );
};

export default PersonsPage;
