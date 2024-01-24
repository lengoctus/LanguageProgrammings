import React, { ReactNode, LazyExoticComponent, FC } from "react";
import { RouteObject } from "react-router-dom";

const FullLayout: LazyExoticComponent<FC<{}>> = React.lazy(
  () => import("../layouts/FullLayout")
);

const Themeroutes = [
  {
    // path: "/",
    // element: <FullLayout />,
    // children: [
    //   { path: "/", element: <Navigate to="/starter" /> },
    //   { path: "/starter", exact: true, element: <Starter /> },
    //   { path: "/about", exact: true, element: <About /> },
    //   { path: "/alerts", exact: true, element: <Alerts /> },
    //   { path: "/badges", exact: true, element: <Badges /> },
    //   { path: "/buttons", exact: true, element: <Buttons /> },
    //   { path: "/cards", exact: true, element: <Cards /> },
    //   { path: "/grid", exact: true, element: <Grid /> },
    //   { path: "/table", exact: true, element: <Tables /> },
    //   { path: "/forms", exact: true, element: <Forms /> },
    //   {
    //     path: "/breadcrumbs",
    //     exact: true,
    //     element: <Breadcrumbs />,
    //   },
    // ],
  },
];

export default Themeroutes;
