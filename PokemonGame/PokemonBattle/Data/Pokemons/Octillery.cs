using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Octillery : Pokemon
	{
		public override string Name => "Octillery";
		public override List<Ability> AvailableAbilities => new() {new Suctioncups(), new Sniper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moody() };
		public override Stats BaseStats => new Stats(75, 105, 75, 105, 75, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Octazooka() },
			[1] = new List<Move>() { new Octazooka(), new Gunkshot(), new Rockblast(), new Helpinghand(), new Watergun(), new Wrap(), new Waterpulse(), new Focusenergy() },
			[12] = new List<Move>() { new Psybeam() },
			[16] = new List<Move>() { new Aurorabeam() },
			[20] = new List<Move>() { new Bubblebeam() },
			[24] = new List<Move>() { new Lockon() },
			[30] = new List<Move>() { new Bulletseed() },
			[36] = new List<Move>() { new Icebeam() },
			[42] = new List<Move>() { new Hydropump() },
			[48] = new List<Move>() { new Soak() },
			[54] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Blizzard(), new Bounce(), new Brine(), new Bulletseed(), new Chargebeam(), new Dive(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Fireblast(), new Flamethrower(), new Flashcannon(), new Focusenergy(), new Gigaimpact(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icywind(), new Liquidation(), new Mudshot(), new Payback(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Rockblast(), new Round(), new Scald(), new Screech(), new Seedbomb(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Thief(), new Thunderwave(), new Waterfall(), new Waterpulse(), new Whirlpool() };
		public override int Weight => 285;
		public override int ExpYield => 168;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}