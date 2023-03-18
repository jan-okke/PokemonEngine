using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Solrock : Pokemon
	{
		public override string Name => "Solrock";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
		public override Stats BaseStats => new Stats(90, 95, 85, 55, 65, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Flareblitz(), new Moves.Morningsun(), new Moves.Tackle(), new Moves.Harden(), new Moves.Confusion(), new Moves.Rockthrow() },
			[5] = new List<Move>() { new Moves.Hypnosis() },
			[10] = new List<Move>() { new Moves.Rockpolish() },
			[15] = new List<Move>() { new Moves.Rockslide() },
			[20] = new List<Move>() { new Moves.Zenheadbutt() },
			[25] = new List<Move>() { new Moves.Cosmicpower() },
			[30] = new List<Move>() { new Moves.Psychic() },
			[35] = new List<Move>() { new Moves.Stoneedge() },
			[40] = new List<Move>() { new Moves.Solarbeam() },
			[45] = new List<Move>() { new Moves.Wonderroom() },
			[50] = new List<Move>() { new Moves.Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Allyswitch(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Cosmicpower(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Flash(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gyroball(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Meteorbeam(), new Moves.Overheat(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Trickroom(), new Moves.Weatherball(), new Moves.Willowisp(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
		public override int Weight => 1540;
		public override int ExpYield => 161;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}