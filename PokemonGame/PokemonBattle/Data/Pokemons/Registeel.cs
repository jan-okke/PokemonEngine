using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Registeel : Pokemon
	{
		public override string Name => "Registeel";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Clearbody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Lightmetal() };
		public override Stats BaseStats => new Stats(80, 75, 150, 75, 150, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Chargebeam(), new Moves.Metalclaw() },
			[6] = new List<Move>() { new Moves.Bulldoze() },
			[12] = new List<Move>() { new Moves.Ancientpower() },
			[18] = new List<Move>() { new Moves.Stomp() },
			[24] = new List<Move>() { new Moves.Ironhead(), new Moves.Flashcannon() },
			[30] = new List<Move>() { new Moves.Curse() },
			[36] = new List<Move>() { new Moves.Irondefense(), new Moves.Amnesia() },
			[42] = new List<Move>() { new Moves.Hammerarm() },
			[48] = new List<Move>() { new Moves.Heavyslam() },
			[54] = new List<Move>() { new Moves.Superpower() },
			[60] = new List<Move>() { new Moves.Lockon() },
			[66] = new List<Move>() { new Moves.Zapcannon() },
			[72] = new List<Move>() { new Moves.Hyperbeam() },
			[78] = new List<Move>() { new Moves.Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Amnesia(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Chargebeam(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Meteorbeam(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockclimb(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Selfdestruct(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave() };
		public override int Weight => 2050;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}