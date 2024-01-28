import { FC } from "react";
import { RouteObject, useRoutes } from "react-router-dom";
import FullLayout from "../layouts/FullLayout";

const AppRouter: FC = () => {
  const mainRoutes: RouteObject = {
    path: "/",
    element: <FullLayout />,
    children: [],
  };

  const routing = useRoutes([mainRoutes]);

  return <>{routing}</>;
};

export default AppRouter;
