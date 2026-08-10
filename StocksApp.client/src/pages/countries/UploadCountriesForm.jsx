import { useMutation } from "@tanstack/react-query";
import { useRef, useState } from "react";
import { uploadCountriesExcelFileApi } from "../../api/countries";
import toast from "react-hot-toast";

const UploadCountriesForm = () => {
  const [file, setFile] = useState(null);
  const [isDragging, setIsDragging] = useState(false);
  const [uploadProgress, setUploadProgress] = useState(0);
  const fileInputRef = useRef();
 
  const { mutate: uploadFile, isPending } = useMutation({
    mutationFn: async (selectedFile) => {
      return await uploadCountriesExcelFileApi({
        file: selectedFile,
        onProgress: (percent) => setUploadProgress(percent),
      });
    },
    onSuccess: (data) => {
      console.log('from onSuccess');
      setFile(null);
      setUploadProgress(0);
      if(data){
        toast.success(`${data} countries added successfully`);
      }else if( data === 0){
        toast.success("All countries in the file already exists or file is empty", {
            duration:4000
        })
      }
    },
    onError: (error) => {
      console.log('from onError', error);
      setFile(null);
      setUploadProgress(0);
      toast.error(error.message || "failed to upload file");
    },
  });

  function validateAndSetFile(selectedFile) {
    if (!selectedFile) return;

    const validExtensions = [".xlsx", ".xls", ".csv"];
    const fileExtension = selectedFile.name
      .slice(selectedFile.name.lastIndexOf("."))
      .toLowerCase();

    if (validExtensions.includes(fileExtension)) {
      setFile(selectedFile);
    } else {
      toast.error("UnSupported media file", {
        duration: 5000,
      });
    }
  }

  // Drag & Drop handlers
  function handleDragOver(e) {
    e.preventDefault();
    setIsDragging(true);
  }

  function handleDragLeave() {
    setIsDragging(false);
  }

  function handleDrop(e) {
    e.preventDefault();
    setIsDragging(false);
    if (e.dataTransfer.files && e.dataTransfer.files[0]) {
      validateAndSetFile(e.dataTransfer.files[0]);
    }
  }

  function handleSubmit(e) {
    e.preventDefault();
    if (file) {
      uploadFile(file);
    }
  }
  return (
    <div className="max-w-md mx-auto mt-8 p-6 bg-white border border-gray-200 rounded-lg shadow-sm">
      <h2 className="text-xl font-bold text-gray-800 mb-4">
        Upload Countries Excel
      </h2>

      <form onSubmit={handleSubmit} className="space-y-4">
        {/* Drop Zone */}
        <div
          onDragOver={e => handleDragOver(e)}
          onDragLeave={e => handleDragLeave(e)}
          onDrop={(event) => handleDrop(event)}
          onClick={() => fileInputRef.current?.click()}
          className={`border-2 border-dashed rounded-lg p-6 text-center cursor-pointer transition-colors 
            ${
              isDragging
                ? "border-blue-500 bg-blue-50"
                : file
                  ? "border-green-500 bg-green-50"
                  : "border-gray-300 hover:border-gray-400 bg-gray-50"
            }`}
        >
          <input
            ref={fileInputRef}
            type="file"
            accept=".xlsx, .xls, .csv"
            onChange={(e) => validateAndSetFile(e.target.files?.[0])}
            className="hidden"
          />

          <div className="flex flex-col items-center space-y-2">
            <svg
              className={`w-10 h-10 ${file ? "text-green-600" : "text-gray-400"}`}
              fill="none"
              stroke="currentColor"
              viewBox="0 0 24 24"
            >
              <path
                strokeLinecap="round"
                strokeLinejoin="round"
                strokeWidth="2"
                d="M7 16a4 4 0 01-.88-7.903A5 5 0 1115.9 6L16 6a5 5 0 011 9.9M15 13l-3-3m0 0l-3 3m3-3v12"
              />
            </svg>

            {file ? (
              <p className="text-sm font-medium text-green-700 break-all">
                Selected: {file.name}
              </p>
            ) : (
              <>
                <p className="text-sm font-medium text-gray-700">
                  Drag & Drop your Excel file here
                </p>
                <p className="text-xs text-gray-500">
                  or click to browse (.xlsx, .xls, .csv)
                </p>
              </>
            )}
          </div>
        </div>
        {/* Upload Progress Bar */}
        {isPending && (
          <div className="space-y-1">
            <div className="flex justify-between text-xs text-gray-600">
              <span>Uploading...</span>
              <span>{uploadProgress}%</span>
            </div>
            <progress
              value={uploadProgress}
              max="100"
              className="w-full h-2 rounded overflow-hidden accent-blue-600"
            />
          </div>
        )}

        <button
          type="submit"
          disabled={!file || isPending}
          className="w-full bg-blue-600 text-white py-2 px-4 rounded hover:bg-blue-700 disabled:opacity-50 disabled:cursor-not-allowed font-medium transition-colors"
        >
          {isPending ? "Uploading..." : "Upload File"}
        </button>
      </form>
    </div>
  );
};

export default UploadCountriesForm;
