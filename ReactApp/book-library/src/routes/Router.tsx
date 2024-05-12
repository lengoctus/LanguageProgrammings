import { createBrowserRouter } from "react-router-dom";
import { Main } from "../layouts/Main";

const Router = createBrowserRouter([
  {
    path: "/",
    element: <div>Home</div>,
    // loader:
    children: [
      {
        path: "/",
        element: <Main />,
        // loader:
      },
    ],
  },
  {
    path: "/about",
    element: <div>About</div>,
  },
]);

export default Router;
