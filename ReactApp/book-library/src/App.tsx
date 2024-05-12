import { FC } from "react";
import { RouterProvider } from "react-router-dom";
import Router from "./routes/Router";

const App: FC = () => <RouterProvider router={Router}></RouterProvider>;

export default App;
