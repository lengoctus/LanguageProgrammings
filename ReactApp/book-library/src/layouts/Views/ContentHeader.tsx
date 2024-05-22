import { Col, Input, Row } from "reactstrap";
import InputBox from "../../components/InputBox";

let hostestProds = [
  { actor: "Frank Miller", name: "Batman :The Dark Knight", photo: "" },
  { actor: "Frank Miller", name: "Batman :The Dark Knight", photo: "" },
  { actor: "Frank Miller", name: "Batman :The Dark Knight", photo: "" },
  { actor: "Frank Miller", name: "Batman :The Dark Knight", photo: "" },
];

interface IContentHeaderProps {}

export const ContentHeader: React.FC<IContentHeaderProps> = () => {
  return (
    <div>
      <div className="search-banner">
        <div>
          <InputBox
            id="searchText"
            name="searchText"
            placeholder="Search"
            type="text"
          />
        </div>
        <div>Banner</div>
      </div>
      <div className="profile-recentAction"></div>
    </div>
  );
};
