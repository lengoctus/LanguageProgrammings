import { Spinner } from "reactstrap";
import "./loader.sass";

interface ILoaderProps {}

export const Loader: React.FC<ILoaderProps> = () => {
  alert("Loader");
  console.log("Loader");

  return (
    <div className="fallback-spinner">
      <div className="loading">
        <Spinner color="primary" />
      </div>
    </div>
  );
};
