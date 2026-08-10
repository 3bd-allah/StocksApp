/* eslint-disable react-refresh/only-export-components */
import { lazy, StrictMode } from "react";
import { createRoot } from "react-dom/client";
import "./index.css";
import { createBrowserRouter, RouterProvider } from "react-router";
import { QueryClientProvider } from "@tanstack/react-query";
import PersonsSection from "./pages/persons/PersonsSection.jsx";
// global axios configuration
import "./api/configuration/axios-global-config.js";
import App from "./App.jsx";
import RootErrorBoundary from "./routes/RootErrorBoundary.jsx";
import { loader as personDetailsLoader } from "./routes/PersonDetails.jsx";
import EditPerson from "./routes/EditPerson.jsx";
import { queryClient } from "./queries/queryClient.js";
import DeletePerson from "./routes/DeletePerson.jsx";
import PersonDetails from "./routes/PersonDetails.jsx";
import DownloadAsPDF from "./routes/DownloadAsPDF.jsx";
import UploadCountries from "./routes/UploadCountries.jsx";
// lazy loading
const Persons = lazy(() => import("./routes/Persons.jsx"));
const CompanyProfile = lazy(() => import("./routes/Company.jsx"));
const NewPerson = lazy(() => import("./routes/NewPerson.jsx"));

const router = createBrowserRouter([
  {
    path: "/",
    element: <App />,
    errorElement: <RootErrorBoundary />,
    children: [
      {
        path: "company",
        element: <CompanyProfile />,
        loader: () =>
          import("./routes/Company.jsx").then((module) => module.loader()),
      },
      {
        path: "persons",
        element: <Persons />,
        children: [
          { index: true, element: <PersonsSection /> },
          { path: "create-new", element: <NewPerson /> },
          { path: "download", element: <DownloadAsPDF />,  },
          {
            path: ":personId",
            loader: personDetailsLoader,
            children: [
              { index: true, element: <PersonDetails /> },
              { path: "edit", element: <EditPerson /> },
              { path: "delete", element: <DeletePerson /> },
            ],
          },
        ],
      },
      {
        path:'country',
        element:<UploadCountries />,
        
      }
    ],
  },
]);

createRoot(document.getElementById("root")).render(
  <StrictMode>
    <QueryClientProvider client={queryClient}>
      <RouterProvider router={router} />
    </QueryClientProvider>
  </StrictMode>,
);
