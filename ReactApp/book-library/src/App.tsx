import { useRoutes } from "react-router-dom";
import AppRouter from "./routes/Router";

export const App = () => {
  return (
    <div className="dark">
      <AppRouter />
    </div>
  );
};
