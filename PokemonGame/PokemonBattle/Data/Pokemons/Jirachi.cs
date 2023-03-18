using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Jirachi : Pokemon
	{
		public override string Name => "Jirachi";
		public override List<Ability> AvailableAbilities => new() {new Serenegrace() };
		public override Stats BaseStats => new Stats(100, 100, 100, 100, 100, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Confusion(), new Wish() },
			[7] = new List<Move>() { new Swift() },
			[14] = new List<Move>() { new Helpinghand() },
			[21] = new List<Move>() { new Lifedew() },
			[28] = new List<Move>() { new Zenheadbutt() },
			[35] = new List<Move>() { new Gravity() },
			[42] = new List<Move>() { new Psychic() },
			[49] = new List<Move>() { new Meteormash() },
			[56] = new List<Move>() { new Healingwish() },
			[63] = new List<Move>() { new Rest() },
			[70] = new List<Move>() { new Futuresight() },
			[77] = new List<Move>() { new Doubleedge() },
			[84] = new List<Move>() { new Cosmicpower() },
			[91] = new List<Move>() { new Lastresort() },
			[98] = new List<Move>() { new Doomdesire() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Allyswitch(), new Amnesia(), new Aurasphere(), new Batonpass(), new Bodyslam(), new Calmmind(), new Chargebeam(), new Charm(), new Cosmicpower(), new Dazzlinggleam(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Firepunch(), new Flash(), new Flashcannon(), new Fling(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Icywind(), new Imprison(), new Irondefense(), new Ironhead(), new Lightscreen(), new Magicroom(), new Megakick(), new Megapunch(), new Meteorbeam(), new Metronome(), new Playrough(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Sandstorm(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Stealthrock(), new Steelbeam(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Trick(), new Trickroom(), new Uproar(), new Uturn(), new Waterpulse(), new Zenheadbutt() };
		public override int Weight => 11;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}