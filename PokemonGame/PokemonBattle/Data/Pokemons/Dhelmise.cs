using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dhelmise : Pokemon
	{
		public override string Name => "Dhelmise";
		public override List<Ability> AvailableAbilities => new() {new Steelworker() };
		public override Stats BaseStats => new Stats(70, 131, 100, 86, 90, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Rapidspin() },
			[4] = new List<Move>() { new Astonish() },
			[8] = new List<Move>() { new Wrap() },
			[12] = new List<Move>() { new Megadrain() },
			[16] = new List<Move>() { new Growth() },
			[20] = new List<Move>() { new Gyroball() },
			[24] = new List<Move>() { new Switcheroo() },
			[28] = new List<Move>() { new Gigadrain() },
			[32] = new List<Move>() { new Whirlpool() },
			[36] = new List<Move>() { new Heavyslam() },
			[40] = new List<Move>() { new Slam() },
			[44] = new List<Move>() { new Shadowball() },
			[48] = new List<Move>() { new Metalsound() },
			[52] = new List<Move>() { new Anchorshot() },
			[56] = new List<Move>() { new Energyball() },
			[60] = new List<Move>() { new Phantomforce() },
			[64] = new List<Move>() { new Powerwhip() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Assurance(), new Bodypress(), new Brickbreak(), new Brine(), new Brutalswing(), new Bulldoze(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Flashcannon(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Gyroball(), new Heavyslam(), new Helpinghand(), new Hex(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Liquidation(), new Muddywater(), new Payback(), new Phantomforce(), new Poltergeist(), new Powerwhip(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Round(), new Shadowball(), new Shadowclaw(), new Sleeptalk(), new Sludgewave(), new Snore(), new Solarbeam(), new Solarblade(), new Steelroller(), new Substitute(), new Sunnyday(), new Surf(), new Swordsdance(), new Thief(), new Whirlpool() };
		public override int Weight => 2100;
		public override int ExpYield => 181;
		public override int CatchRate => 25;
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