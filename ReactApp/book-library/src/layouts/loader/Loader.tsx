import { Spinner } from "reactstrap";
import "./loader.sass";

export const Loader: React.FC = () => {
  return (
    <div className="fallback-spinner">
      <div className="loading">
        <Spinner color="primary" />
      </div>
    </div>
  );
};
