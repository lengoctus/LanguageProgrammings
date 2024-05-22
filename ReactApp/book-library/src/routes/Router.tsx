import { createBrowserRouter } from "react-router-dom";
import { Main } from "../layouts/Main";
import { Loader } from "../layouts/loader/loader";
import { Content } from "../layouts/Content";

const Router = createBrowserRouter([
  {
    path: "/",
    element: <Main />,
    children: [{ path: "/", element: <Content /> }],
  },
]);

export default Router;
