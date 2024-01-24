import { RouteObject, useRoutes } from "react-router-dom";
import Themeroutes from "./routes/Router";
import FullLayout from "./layouts/FullLayout";

export const App = () => {
  const routing = useRoutes([{ path: "/", element: <FullLayout /> }]);
  return <div className="dark">{routing}</div>;
};
