import { Link } from "react-router-dom";
import { ReactComponent as LogoDark } from "../assets/images/logos/adminpro.svg";

export const Logo = () => {
  return (
    <Link to="/">
      <LogoDark />
    </Link>
  );
};
