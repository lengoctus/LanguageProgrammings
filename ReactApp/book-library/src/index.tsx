import React, { Suspense } from "react";
import ReactDOM from "react-dom/client";
import "./assets/scss/style.scss";
import { Loader } from "./layouts/loader/Loader";
import { HashRouter } from "react-router-dom";
import { App } from "./App";
const root = ReactDOM.createRoot(
  document.getElementById("root") as HTMLElement
);

root.render(
  <React.StrictMode>
    <Suspense fallback={<Loader />}>
      <HashRouter>
        <App />
      </HashRouter>
    </Suspense>
  </React.StrictMode>
);
