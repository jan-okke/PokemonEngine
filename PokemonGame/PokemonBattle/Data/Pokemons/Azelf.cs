using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Azelf : Pokemon
	{
		public override string Name => "Azelf";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(75, 125, 70, 115, 125, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Confusion(), new Rest() },
			[7] = new List<Move>() { new Swift() },
			[14] = new List<Move>() { new Detect() },
			[21] = new List<Move>() { new Psybeam() },
			[28] = new List<Move>() { new Imprison() },
			[35] = new List<Move>() { new Extrasensory() },
			[42] = new List<Move>() { new Nastyplot() },
			[49] = new List<Move>() { new Psychic() },
			[56] = new List<Move>() { new Uproar() },
			[63] = new List<Move>() { new Futuresight() },
			[70] = new List<Move>() { new Lastresort() },
			[77] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Allyswitch(), new Assurance(), new Batonpass(), new Calmmind(), new Chargebeam(), new Dazzlinggleam(), new Doubleteam(), new Drainingkiss(), new Drainpunch(), new Dreameater(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Explosion(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Flash(), new Fling(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Imprison(), new Irontail(), new Lightscreen(), new Magicroom(), new Metronome(), new Nastyplot(), new Payback(), new Playrough(), new Protect(), new Psychic(), new Psychocut(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Sandstorm(), new Selfdestruct(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snore(), new Stealthrock(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Taunt(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Torment(), new Triattack(), new Trick(), new Trickroom(), new Uproar(), new Uturn(), new Waterpulse(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 3;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}